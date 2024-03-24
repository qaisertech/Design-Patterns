﻿using Factory_Pattern.Enums;
using Factory_Pattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.Entities
{
    public class AirConditioner
    {
        private readonly Dictionary<Actions, AirConditionerFactory> _factories;
        public AirConditioner()
        {
            _factories = new Dictionary<Actions, AirConditionerFactory>
            {
                { Actions.Cooling, new CoolingFactory() },
                { Actions.Warming, new WarmingFactory() },
            };
            //_factories = new Dictionary<Actions, AirConditionerFactory>();
            //foreach (Actions action in Enum.GetValues(typeof(Actions)))
            //{
            //    var factory = (AirConditionerFactory)Activator.CreateInstance(Type.GetType(Enum.GetName(typeof(Actions), action) + "Factory"));
            //    _factories.Add(action, factory);
            //}
        }

        public IAirConditioner ExecuteCreation(Actions action, double temperature) => _factories[action].Create(temperature);

    }
}
