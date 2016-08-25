﻿using System;
using System.Collections.Generic;

namespace SimpleECS
{
	public class Entity
	{
		public int componentCount
		{
			get
			{
				return components.Count;
			}
		}

		private readonly Dictionary<Type, IComponent> components = new Dictionary<Type, IComponent>();

		public T GetComponent<T>() where T : IComponent
		{
			throw new NotImplementedException();
		}

		public bool HasComponent<T>() where T : IComponent
		{
			return components.ContainsKey(typeof(T));
		}

		public T AddComponent<T>() where T : IComponent, new()
		{
			T newComponent = new T();
			components.Add(newComponent.GetType(), newComponent);
			return newComponent;
		}

		public void RemoveComponent<T>(T component) where T : IComponent
		{
			throw new NotImplementedException();
		}

		public void ClearAllComponents()
		{
			components.Clear();
		}
	}
}

