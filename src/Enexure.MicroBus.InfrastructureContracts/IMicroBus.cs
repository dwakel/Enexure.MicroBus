﻿using System.Threading.Tasks;

namespace Enexure.MicroBus
{
	public interface IMicroBus
	{
		Task Send<TCommand>(TCommand busCommand)
			where TCommand : ICommand;

		Task Publish<TEvent>(TEvent @event)
			where TEvent : IEvent;

		Task<TResult> Query<TQuery, TResult>(IQuery<TQuery, TResult> query)
			where TQuery : IQuery<TQuery, TResult>
			where TResult : IResult;
	}
}
