using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;

namespace $rootnamespace$
{
	public class $commandname$CommandHandler : IRequestHandler<$commandname$Command, $commandname$CommandResponse>
	{

		public $commandname$CommandHandler()
		{
		}

		public async Task<$commandname$CommandResponse> Handle($commandname$Command request, CancellationToken cancellationToken)
		{
			var validator = new $commandname$CommandValidator();
            var result = validator.Validate(request);

            if (!result.IsValid)
            {
                throw new MediatRValidationException(result.ToString());
            }

			throw new NotImplementedException();
		}
	}
}
