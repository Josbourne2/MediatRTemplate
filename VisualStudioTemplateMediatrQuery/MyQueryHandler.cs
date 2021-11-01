using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;

namespace $rootnamespace$
{
	public class $Queryname$QueryHandler : IRequestHandler<$Queryname$Query, $Queryname$QueryResponse>
	{

		public $Queryname$QueryHandler()
		{
		}

		public async Task<$Queryname$QueryResponse> Handle($Queryname$Query request, CancellationToken cancellationToken)
		{
			var validator = new $Queryname$QueryValidator();
            var result = validator.Validate(request);

            if (!result.IsValid)
            {
                throw new ValidationException(result.ToString());
            }

			throw new NotImplementedException();
		}
	}
}
