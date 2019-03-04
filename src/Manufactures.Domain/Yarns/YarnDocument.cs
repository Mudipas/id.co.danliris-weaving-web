﻿using Infrastructure.Domain;
using Manufactures.Domain.Events;
using Manufactures.Domain.GlobalValueObjects;
using Manufactures.Domain.Yarns.ReadModels;
using Moonlay;
using System;

namespace Manufactures.Domain.Yarns
{
    public class YarnDocument : AggregateRoot<YarnDocument, YarnDocumentReadModel>
    {
        public string Code { get; private set; }
        public string Name { get; private set; }
        public string Tags { get; private set; }
        public MaterialTypeValueObject MaterialTypeDocument { get; private set; }
        public YarnNumberValueObject RingDocument { get; private set; }

        public YarnDocument(Guid id,
                            string code,
                            string name,
                            string tags,
                            MaterialTypeValueObject materialTypeDocument,
                            YarnNumberValueObject ringDocument) : base(id)
        {
            // Validate Properties
            Validator.ThrowIfNullOrEmpty(() => code);
            Validator.ThrowIfNullOrEmpty(() => name);
            Validator.ThrowIfNullOrEmpty(() => tags);
            Validator.ThrowIfNull(() => materialTypeDocument);
            Validator.ThrowIfNull(() => ringDocument);

            this.MarkTransient();

            Identity = id;
            Code = code;
            Name = name;
            Tags = tags;
            MaterialTypeDocument = materialTypeDocument;
            RingDocument = ringDocument;

            ReadModel = new YarnDocumentReadModel(Identity)
            {
                Code = this.Code,
                Name = this.Name,
                Tags = this.Tags,
                MaterialTypeDocument = this.MaterialTypeDocument.Serialize(),
                RingDocument = this.RingDocument.Serialize()
            };

            ReadModel.AddDomainEvent(new OnYarnAddDocument(this.Identity));
        }

        public YarnDocument(YarnDocumentReadModel readModel) : base(readModel)
        {
            this.Code = readModel.Code;
            this.Name = readModel.Name;
            this.Tags = readModel.Tags;
            this.MaterialTypeDocument = readModel.MaterialTypeDocument.Deserialize<MaterialTypeValueObject>();
            this.RingDocument = readModel.RingDocument.Deserialize<YarnNumberValueObject>();
        }
        
        public void SetCode(string code)
        {
            Validator.ThrowIfNullOrEmpty(() => code);

            if (Code != code)
            {
                Code = code;
                ReadModel.Code = Code;

                MarkModified();
            }
        }

        public void SetName(string name)
        {
            Validator.ThrowIfNullOrEmpty(() => name);

            if (Name != name)
            {
                Name = name;
                ReadModel.Name = Name;

                MarkModified();
            }
        }

        public void SetTags(string tags)
        {
            Validator.ThrowIfNullOrEmpty(() => tags);

            if (Tags != tags)
            {
                Tags = tags;
                ReadModel.Tags = Tags;

                MarkModified();
            }
        }

        public void SetMaterialTypeDocument(MaterialTypeValueObject document)
        {
            Validator.ThrowIfNull(() => document);
            int indexDiffence = 0;


            if (MaterialTypeDocument.Code != document.Code)
            {
                indexDiffence++;
            }

            if (MaterialTypeDocument.Name != document.Name)
            {
                indexDiffence++;
            }

            if (indexDiffence > 0)
            {
                MaterialTypeDocument = new MaterialTypeValueObject(document.Id, document.Code, document.Name);
                ReadModel.MaterialTypeDocument = MaterialTypeDocument.Serialize();

                MarkModified();
            }
        }

        public void SetRingDocument(YarnNumberValueObject document)
        {
            Validator.ThrowIfNull(() => document);
            int indexDiffence = 0;


            if (RingDocument.Code != document.Code)
            {
                indexDiffence++;
            }

            if (RingDocument.Number != document.Number)
            {
                indexDiffence++;
            }

            if (indexDiffence > 0)
            {
                RingDocument = new YarnNumberValueObject(document.Id, document.Code, document.Number);
                ReadModel.RingDocument = RingDocument.Serialize();

                MarkModified();
            }
        }

        protected override YarnDocument GetEntity()
        {
            return this;
        }
    }
}
