using apiProdutos2.Models;
using FluentNHibernate.Mapping;

namespace apiProdutos2.Infra.Maps
{
    public class MenuMap : ClassMap<Menu>
    {
        public MenuMap()
        {
            Schema("MENU_ON");
            Table("MENU");
            Id(p => p.Id).Column("Id");
            Map(p => p.Nome).Column("Nome");
            Map(p => p.Descricao).Column("Descricao");
            Map(p => p.Ativo).Column("Ativo");
            References(p => p.Loja).Column("Id_loja").Not.Nullable();
            HasMany(p => p.Categorias).KeyColumn("Id_menu").Inverse().Cascade.All();
        }
    }
}