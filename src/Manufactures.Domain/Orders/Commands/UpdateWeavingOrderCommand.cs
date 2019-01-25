﻿using FluentValidation;
using Infrastructure.Domain.Commands;
using Manufactures.Domain.Orders.ValueObjects;
using System;

namespace Manufactures.Domain.Orders.Commands
{
    public class UpdateWeavingOrderCommand : ICommand<WeavingOrderDocument>
    {
        public void SetId(Guid id) { Id = id; }
        public Guid Id { get; private set; }
        public FabricConstructionDocument FabricConstructionDocument { get; set; }
        public string WarpOrigin { get; set; }
        public string WeftOrigin { get; set; }
        public int WholeGrade { get; set; }
        public string YarnType { get; set; }
        public Period Period { get; set; }
        public Composition Composition { get; set; }
        public WeavingUnit WeavingUnit { get; set; }
    }

    public class UpdateWeavingOrderCommandValidator : AbstractValidator<UpdateWeavingOrderCommand>
    {
        public UpdateWeavingOrderCommandValidator()
        {
            RuleFor(command => command.FabricConstructionDocument.Id).NotNull();
            RuleFor(command => command.FabricConstructionDocument.ConstructionNumber).NotNull();
            RuleFor(command => command.WarpOrigin).NotNull();
            RuleFor(command => command.WeftOrigin).NotNull();
            RuleFor(command => command.WholeGrade).NotNull();
            RuleFor(command => command.YarnType).NotNull();
            RuleFor(command => command.Period.Month).NotNull();
            RuleFor(command => command.Period.Year).NotNull();
            RuleFor(command => command.Composition.CompositionOfPoly).NotNull();
            RuleFor(command => command.Composition.CompositionOfCotton).NotNull();
            RuleFor(command => command.Composition.OtherComposition).NotNull();
            RuleFor(command => command.WeavingUnit._id).NotNull();
            RuleFor(command => command.WeavingUnit.Name).NotNull();
        }
    }
}
