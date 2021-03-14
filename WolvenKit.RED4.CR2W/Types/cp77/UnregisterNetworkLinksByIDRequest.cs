using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnregisterNetworkLinksByIDRequest : gameScriptableSystemRequest
	{
		private entEntityID _iD;

		[Ordinal(0)] 
		[RED("ID")] 
		public entEntityID ID
		{
			get
			{
				if (_iD == null)
				{
					_iD = (entEntityID) CR2WTypeManager.Create("entEntityID", "ID", cr2w, this);
				}
				return _iD;
			}
			set
			{
				if (_iD == value)
				{
					return;
				}
				_iD = value;
				PropertySet(this);
			}
		}

		public UnregisterNetworkLinksByIDRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
