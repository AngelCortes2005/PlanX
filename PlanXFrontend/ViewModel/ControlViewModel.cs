﻿using PlanXFrontend.Entidades.Entities;
using Syncfusion.Maui.Scheduler;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanXFrontend.ViewModel
{
    public class ControlViewModel
    {
        
        public ObservableCollection<SchedulerAppointment> SchedulerEvents { get; set; }

        



        public ControlViewModel() {

            this.SchedulerEvents = new ObservableCollection<SchedulerAppointment>();


            foreach (Evento evento in ListaEventos.eventos)
            {
                SchedulerEvents.Add(new SchedulerAppointment()
                {
                    StartTime = evento.fecHoraInicio,
                    EndTime = evento.fecHoraFin,
                    Subject = evento.nombre,

                });
            }
        }
    }
}
