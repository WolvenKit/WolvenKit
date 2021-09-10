using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entColliderComponentShape : ISerializable
	{
		[Ordinal(0)] 
		[RED("localToBody")] 
		public Transform LocalToBody
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}
	}
}
