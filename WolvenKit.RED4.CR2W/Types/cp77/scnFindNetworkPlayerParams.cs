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
			get
			{
				if (_networkId == null)
				{
					_networkId = (CUInt32) CR2WTypeManager.Create("Uint32", "networkId", cr2w, this);
				}
				return _networkId;
			}
			set
			{
				if (_networkId == value)
				{
					return;
				}
				_networkId = value;
				PropertySet(this);
			}
		}

		public scnFindNetworkPlayerParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
