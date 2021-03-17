using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StopVFXEffector : gameEffector
	{
		private CName _vfxName;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("vfxName")] 
		public CName VfxName
		{
			get => GetProperty(ref _vfxName);
			set => SetProperty(ref _vfxName, value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public StopVFXEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
