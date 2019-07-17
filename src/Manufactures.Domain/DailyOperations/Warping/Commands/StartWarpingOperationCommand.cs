﻿using FluentValidation;
using Infrastructure.Domain.Commands;
using Manufactures.Domain.Shared.ValueObjects;
using Newtonsoft.Json;
using System;

namespace Manufactures.Domain.DailyOperations.Warping.Commands
{
    public class StartWarpingOperationCommand
        : ICommand<DailyOperationWarpingDocument>
    {
        [JsonProperty(PropertyName = "Id")]
        public Guid Id { get; set; }

        [JsonProperty(PropertyName = "Id")]
        public BeamId BeamId { get; set; }

        [JsonProperty(PropertyName = "DateOperation")]
        public DateTimeOffset DateOperation { get; set; }

        [JsonProperty(PropertyName = "TimeOperation")]
        public String TimeOperation { get; set; }

        [JsonProperty(PropertyName = "OperatorId")]
        public OperatorId OperatorId { get; set; }
    }

    public class StartWarpingOperationCommandValidator
        : AbstractValidator<StartWarpingOperationCommand>
    {
        public StartWarpingOperationCommandValidator()
        {
            RuleFor(command => command.Id).NotEmpty();
            RuleFor(command => command.BeamId.Value).NotEmpty();
            RuleFor(command => command.DateOperation).NotEmpty();
            RuleFor(command => command.TimeOperation).NotEmpty();
            RuleFor(command => command.OperatorId.Value).NotEmpty();
        }
    }
}
