using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entDistanceLODsPresets : ISerializable
	{
		private CStatic<entLODDefinition> _definitions;

		[Ordinal(0)] 
		[RED("definitions", 4)] 
		public CStatic<entLODDefinition> Definitions
		{
			get
			{
				if (_definitions == null)
				{
					_definitions = (CStatic<entLODDefinition>) CR2WTypeManager.Create("static:4,entLODDefinition", "definitions", cr2w, this);
				}
				return _definitions;
			}
			set
			{
				if (_definitions == value)
				{
					return;
				}
				_definitions = value;
				PropertySet(this);
			}
		}

		public entDistanceLODsPresets(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
