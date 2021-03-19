using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamecheatsystemObjCheats : CVariable
	{
		private wCHandle<gameObject> _object;
		private CInt32 _flags;

		[Ordinal(0)] 
		[RED("object")] 
		public wCHandle<gameObject> Object
		{
			get => GetProperty(ref _object);
			set => SetProperty(ref _object, value);
		}

		[Ordinal(1)] 
		[RED("flags")] 
		public CInt32 Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}

		public gamecheatsystemObjCheats(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
