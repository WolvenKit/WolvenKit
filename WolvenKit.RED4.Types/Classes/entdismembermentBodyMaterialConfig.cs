using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entdismembermentBodyMaterialConfig : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("FleshBodyMask")] 
		public CBitField<physicsRagdollBodyPartE> FleshBodyMask
		{
			get => GetPropertyValue<CBitField<physicsRagdollBodyPartE>>();
			set => SetPropertyValue<CBitField<physicsRagdollBodyPartE>>(value);
		}

		[Ordinal(1)] 
		[RED("CyberBodyMask")] 
		public CBitField<physicsRagdollBodyPartE> CyberBodyMask
		{
			get => GetPropertyValue<CBitField<physicsRagdollBodyPartE>>();
			set => SetPropertyValue<CBitField<physicsRagdollBodyPartE>>(value);
		}
	}
}
