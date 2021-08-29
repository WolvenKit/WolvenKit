using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entDismembermentAudioEvent : redEvent
	{
		private CEnum<entAudioDismembermentPart> _bodyPart;
		private Vector4 _position;

		[Ordinal(0)] 
		[RED("bodyPart")] 
		public CEnum<entAudioDismembermentPart> BodyPart
		{
			get => GetProperty(ref _bodyPart);
			set => SetProperty(ref _bodyPart, value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}
	}
}
