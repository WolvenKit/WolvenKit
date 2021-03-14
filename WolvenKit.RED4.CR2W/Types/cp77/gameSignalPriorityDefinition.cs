using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSignalPriorityDefinition : ISerializable
	{
		private CUInt16 _defaultPriority;

		[Ordinal(0)] 
		[RED("defaultPriority")] 
		public CUInt16 DefaultPriority
		{
			get
			{
				if (_defaultPriority == null)
				{
					_defaultPriority = (CUInt16) CR2WTypeManager.Create("Uint16", "defaultPriority", cr2w, this);
				}
				return _defaultPriority;
			}
			set
			{
				if (_defaultPriority == value)
				{
					return;
				}
				_defaultPriority = value;
				PropertySet(this);
			}
		}

		public gameSignalPriorityDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
