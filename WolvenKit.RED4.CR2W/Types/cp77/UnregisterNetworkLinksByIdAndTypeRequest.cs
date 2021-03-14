using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnregisterNetworkLinksByIdAndTypeRequest : gameScriptableSystemRequest
	{
		private entEntityID _iD;
		private CEnum<ELinkType> _type;

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

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<ELinkType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<ELinkType>) CR2WTypeManager.Create("ELinkType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public UnregisterNetworkLinksByIdAndTypeRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
