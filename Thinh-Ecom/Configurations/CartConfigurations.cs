﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thinh_Ecom.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Thinh_Ecom.Configurations
{
    public class CartConfigurations : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");
            builder.HasKey(t => new { t.cart_Id });
            builder.HasOne(t => t.AppUserC).WithMany(ur => ur.CartU)
     .HasForeignKey(pc => pc.cart_UserID);
        }
    }
}
