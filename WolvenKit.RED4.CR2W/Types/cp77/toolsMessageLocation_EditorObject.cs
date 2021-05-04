using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsMessageLocation_EditorObject : toolsIMessageLocation
	{
		private toolsEditorObjectIDPath _path;

		[Ordinal(0)] 
		[RED("path")] 
		public toolsEditorObjectIDPath Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}

		public toolsMessageLocation_EditorObject(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
