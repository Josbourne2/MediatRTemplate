using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace $rootnamespace$
{
	public class $commandname$Command : IRequest<$commandname$CommandResponse>
	{
		public string Name { get; set; }
}
}
