﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BioGorod.Domain.Company;
using QSOrmProject;

namespace BioGorod.Domain.Client
{
	public class ContractLongLeaseAddress : PropertyChangedBase, IDomainObject
	{
		public virtual int Id { get; set; }

		private ContractLongLease contract;

		[Display (Name = "Договор")]
		public virtual ContractLongLease Contract {
			get { return contract; }
			set { SetField (ref contract, value, () => Contract); }
		}

		private DeliveryPoint deliveryPoint;

		[Display (Name = "Адрес объекта")]
		public virtual DeliveryPoint DeliveryPoint {
			get { return deliveryPoint; }
			set { SetField (ref deliveryPoint, value, () => DeliveryPoint); }
		}

		private IList<Cabine> cabines = new List<Cabine>();

		[Display (Name = "Кабинки")]
		public virtual IList<Cabine> Cabines {
		    get { return cabines; }
		    set { SetField (ref cabines, value, () => Cabines); }
		}

		private DateTime? startAt;

		[Display (Name = "Действует с")]
		public virtual DateTime? StartAt {
		    get { return startAt; }
		    set { SetField (ref startAt, value, () => StartAt); }
		}

		private decimal cabineStdCost;

		[Display (Name = "Стоимость кабины(стандарт)")]
		public virtual decimal CabineStdCost {
		    get { return cabineStdCost; }
		    set { SetField (ref cabineStdCost, value, () => CabineStdCost); }
		}

		private decimal cabineWinterCost;

		[Display (Name = "Стоимость кабины(зимний)")]
		public virtual decimal CabineWinterCost {
		    get { return cabineWinterCost; }
		    set { SetField (ref cabineWinterCost, value, () => CabineWinterCost); }
		}

		private decimal additionalServiceStdCost;

		[Display (Name = "Стоимость доп. ТО(стандарт)")]
		public virtual decimal AdditionalServiceStdCost {
		    get { return additionalServiceStdCost; }
		    set { SetField (ref additionalServiceStdCost, value, () => AdditionalServiceStdCost); }
		}

		private decimal additionalServiceWinterCost;

		[Display (Name = "Стоимость доп. ТО(зимний)")]
		public virtual decimal AdditionalServiceWinterCost {
		    get { return additionalServiceWinterCost; }
		    set { SetField (ref additionalServiceWinterCost, value, () => AdditionalServiceWinterCost); }
		}

		private int maintenanceCount;

		[Display (Name = "Количество ТО в месяц")]
		public virtual int MaintenanceCount {
		    get { return maintenanceCount; }
		    set { SetField (ref maintenanceCount, value, () => MaintenanceCount); }
		}

		#region Вычисляемые

		[Display (Name = "Кабинки")]
		public virtual string CabinesText{
			get{
				return String.Join(", ", Cabines.Select(x => x.Number));
			}
		}

		#endregion

		public ContractLongLeaseAddress()
		{
			
		}

		#region Функции

		public virtual ContractLongLeaseAddress Copy(DateTime newDate)
		{
			return new ContractLongLeaseAddress
			{
				Contract = this.Contract,
				AdditionalServiceStdCost = this.AdditionalServiceStdCost,
				AdditionalServiceWinterCost = this.AdditionalServiceWinterCost,
				CabineStdCost = this.CabineStdCost,
				CabineWinterCost = this.CabineWinterCost,
				DeliveryPoint = this.DeliveryPoint,
				MaintenanceCount = this.MaintenanceCount,
				StartAt = newDate
			};
		}

		public virtual void AddCabine(params Cabine[] cabines)
		{
			foreach (var cabine in cabines)
			{
				if (Cabines.Any(x => x.Id == cabine.Id))
					continue;
				Cabines.Add(cabine);
			}
			OnPropertyChanged(() => CabinesText);
		}

		public virtual void RemoveCabine(params Cabine[] cabines)
		{
			foreach (var cabine in cabines)
			{
				Cabines.Remove(cabine);
			}
			OnPropertyChanged(() => CabinesText);
		}

		#endregion
	}
}

