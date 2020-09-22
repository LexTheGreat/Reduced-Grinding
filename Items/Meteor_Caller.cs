using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace ReducedGrinding.Items
{
	public class Meteor_Caller : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Meteor Caller");
			Tooltip.SetDefault("Summons A Meteor.");
		}
		
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 30;
			item.maxStack = 30;
			item.rare = 0;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = 4;
			item.value = Item.buyPrice(0, 10);
			item.UseSound = SoundID.Item3;
			item.consumable = true;
		}

		public override bool CanUseItem(Player player)
		{
			return true;
		}

		public override bool UseItem(Player player)
		{
            WorldGen.dropMeteor();
			return true;
		}
	}
}