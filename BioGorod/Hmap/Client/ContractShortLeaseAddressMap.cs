﻿using System;
using BioGorod.Domain.Client;
using FluentNHibernate.Mapping;

namespace BioGorod.Hmap.Client
{
	public class ContractLongLeaseAddressMap : ClassMap<ContractLongLeaseAddress>
	{
		public ContractLongLeaseAddressMap ()
		{
			Table ("contracts_short_addresses");

			Id (x => x.Id).Column ("id").GeneratedBy.Native ();

			References (x => x.Contract).Column ("contract_id");
			References (x => x.DeliveryPoint).Column ("delivery_point_id");
		}
	}}

