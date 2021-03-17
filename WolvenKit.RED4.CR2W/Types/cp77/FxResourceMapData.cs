using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FxResourceMapData : CVariable
	{
		private CName _key;
		private gameFxResource _resource;

		[Ordinal(0)] 
		[RED("key")] 
		public CName Key
		{
			get => GetProperty(ref _key);
			set => SetProperty(ref _key, value);
		}

		[Ordinal(1)] 
		[RED("resource")] 
		public gameFxResource Resource
		{
			get => GetProperty(ref _resource);
			set => SetProperty(ref _resource, value);
		}

		public FxResourceMapData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
