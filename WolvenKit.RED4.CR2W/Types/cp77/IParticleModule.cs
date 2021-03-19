using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IParticleModule : ISerializable
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

		public IParticleModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
