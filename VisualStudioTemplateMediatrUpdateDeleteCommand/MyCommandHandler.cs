using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;

namespace $rootnamespace$
{
	public class $commandname$CommandHandler : IRequestHandler<$commandname$Command>
	{

		public $commandname$CommandHandler()
		{
		}

		public async Task<Unit> Handle($commandname$Command request, CancellationToken cancellationToken)
		{
			var validator = new $commandname$CommandValidator();
            var result = validator.Validate(request);

            if (!result.IsValid)
            {
                throw new ValidationException(result.ToString());
            }

			//Insert update code here

			return Unit.Value;
		}
	}
}
