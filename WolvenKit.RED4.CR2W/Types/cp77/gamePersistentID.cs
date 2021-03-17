using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePersistentID : CVariable
	{
		private CUInt64 _entityHash;
		private CName _componentName;

		[Ordinal(0)] 
		[RED("entityHash")] 
		public CUInt64 EntityHash
		{
			get => GetProperty(ref _entityHash);
			set => SetProperty(ref _entityHash, value);
		}

		[Ordinal(1)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetProperty(ref _componentName);
			set => SetProperty(ref _componentName, value);
		}

		public gamePersistentID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
