using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisIVisualizerDefinition : ISerializable
	{
		private CEnum<gameinteractionsvisEVisualizerDefinitionFlags> _flags;

		[Ordinal(0)] 
		[RED("flags")] 
		public CEnum<gameinteractionsvisEVisualizerDefinitionFlags> Flags
		{
			get
			{
				if (_flags == null)
				{
					_flags = (CEnum<gameinteractionsvisEVisualizerDefinitionFlags>) CR2WTypeManager.Create("gameinteractionsvisEVisualizerDefinitionFlags", "flags", cr2w, this);
				}
				return _flags;
			}
			set
			{
				if (_flags == value)
				{
					return;
				}
				_flags = value;
				PropertySet(this);
			}
		}

		public gameinteractionsvisIVisualizerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
