﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetSystem.Adaptor;
using AssetSystem.Views;

namespace AssetSystem.Controllers
{
    class EquipmentController:BaseController
    {
        public EquipmentController() : base()
        {
            EquipmentViews = EquipmentViews ?? new EquipmentViews();
            EquipmentAdaptor = EquipmentAdaptor ?? new EquipmentAdaptor();
        }

        public EquipmentViews EquipmentViews;
        public EquipmentAdaptor EquipmentAdaptor;
    }
}