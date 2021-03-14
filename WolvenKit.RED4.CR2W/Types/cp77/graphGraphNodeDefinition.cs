using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class graphGraphNodeDefinition : graphIGraphObjectDefinition
	{
		private CArray<CHandle<graphGraphSocketDefinition>> _sockets;

		[Ordinal(0)] 
		[RED("sockets")] 
		public CArray<CHandle<graphGraphSocketDefinition>> Sockets
		{
			get
			{
				if (_sockets == null)
				{
					_sockets = (CArray<CHandle<graphGraphSocketDefinition>>) CR2WTypeManager.Create("array:handle:graphGraphSocketDefinition", "sockets", cr2w, this);
				}
				return _sockets;
			}
			set
			{
				if (_sockets == value)
				{
					return;
				}
				_sockets = value;
				PropertySet(this);
			}
		}

		public graphGraphNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
