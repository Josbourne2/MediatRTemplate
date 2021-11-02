using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace $rootnamespace$
{
	public class $commandname$Command : IRequest<Unit>
	{
		public string Name { get; set; }
}
}
