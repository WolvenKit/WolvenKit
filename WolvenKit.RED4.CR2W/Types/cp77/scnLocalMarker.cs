using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnLocalMarker : CVariable
	{
		private Transform _transformLS;
		private CName _name;

		[Ordinal(0)] 
		[RED("transformLS")] 
		public Transform TransformLS
		{
			get => GetProperty(ref _transformLS);
			set => SetProperty(ref _transformLS, value);
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		public scnLocalMarker(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
