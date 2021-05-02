using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioSoundComponentSubSystemWrapper : ISerializable
	{
		private CHandle<gameaudioISoundComponentSubSystem> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<gameaudioISoundComponentSubSystem> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public gameaudioSoundComponentSubSystemWrapper(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
