
namespace WolvenKit.RED4.Types
{
	public partial class gamedataUncontrolledMovementEffector_Record
	{
		[RED("ragdollNoGroundThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat RagdollNoGroundThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("ragdollOnCollision")]
		[REDProperty(IsIgnored = true)]
		public CBool RagdollOnCollision
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
