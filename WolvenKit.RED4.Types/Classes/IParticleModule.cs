using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IParticleModule : ISerializable
	{
		private CString _editorName;
		private CString _editorGroup;
		private CBool _isEnabled;

		[Ordinal(0)] 
		[RED("editorName")] 
		public CString EditorName
		{
			get => GetProperty(ref _editorName);
			set => SetProperty(ref _editorName, value);
		}

		[Ordinal(1)] 
		[RED("editorGroup")] 
		public CString EditorGroup
		{
			get => GetProperty(ref _editorGroup);
			set => SetProperty(ref _editorGroup, value);
		}

		[Ordinal(2)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}
	}
}
