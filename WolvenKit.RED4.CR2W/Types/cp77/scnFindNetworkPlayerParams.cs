using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnFindNetworkPlayerParams : CVariable
	{
		private CUInt32 _networkId;

		[Ordinal(0)] 
		[RED("networkId")] 
		public CUInt32 NetworkId
		{
			get => GetProperty(ref _networkId);
			set => SetProperty(ref _networkId, value);
		}

		public scnFindNetworkPlayerParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
