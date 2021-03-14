using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questIONodeDefinition : questDisableableNodeDefinition
	{
		private CName _socketName;

		[Ordinal(2)] 
		[RED("socketName")] 
		public CName SocketName
		{
			get
			{
				if (_socketName == null)
				{
					_socketName = (CName) CR2WTypeManager.Create("CName", "socketName", cr2w, this);
				}
				return _socketName;
			}
			set
			{
				if (_socketName == value)
				{
					return;
				}
				_socketName = value;
				PropertySet(this);
			}
		}

		public questIONodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
