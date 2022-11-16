﻿using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.CategoryId });
            builder.ToTable("ProductInCategories");
            builder.HasOne(x => x.Product).WithMany(p => p.ProductInCategories).HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Category).WithMany(c => c.ProductInCategories).HasForeignKey(x => x.CategoryId);
        }
    }
}
