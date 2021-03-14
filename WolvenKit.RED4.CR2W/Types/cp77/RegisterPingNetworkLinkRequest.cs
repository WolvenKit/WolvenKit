using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterPingNetworkLinkRequest : gameScriptableSystemRequest
	{
		private CArray<SNetworkLinkData> _linksData;

		[Ordinal(0)] 
		[RED("linksData")] 
		public CArray<SNetworkLinkData> LinksData
		{
			get
			{
				if (_linksData == null)
				{
					_linksData = (CArray<SNetworkLinkData>) CR2WTypeManager.Create("array:SNetworkLinkData", "linksData", cr2w, this);
				}
				return _linksData;
			}
			set
			{
				if (_linksData == value)
				{
					return;
				}
				_linksData = value;
				PropertySet(this);
			}
		}

		public RegisterPingNetworkLinkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
