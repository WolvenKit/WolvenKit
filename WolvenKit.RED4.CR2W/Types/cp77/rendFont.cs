using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendFont : CResource
	{
		private DataBuffer _fontBuffer;

		[Ordinal(1)] 
		[RED("fontBuffer")] 
		public DataBuffer FontBuffer
		{
			get => GetProperty(ref _fontBuffer);
			set => SetProperty(ref _fontBuffer, value);
		}

		public rendFont(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
