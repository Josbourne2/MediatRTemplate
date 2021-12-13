using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace $rootnamespace$
{
	public class $commandname$Command : BaseRequest, IRequest<$commandname$CommandResponse>
	{
		public string Name { get; set; }
	}
}
