using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entColliderComponentShape : ISerializable
	{
		private Transform _localToBody;

		[Ordinal(0)] 
		[RED("localToBody")] 
		public Transform LocalToBody
		{
			get => GetProperty(ref _localToBody);
			set => SetProperty(ref _localToBody, value);
		}
	}
}
