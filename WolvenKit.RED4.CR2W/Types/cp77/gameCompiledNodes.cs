using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCompiledNodes : ISerializable
	{
		private CArray<gameCompiledSmartObjectNode> _compiledSmartObjects;

		[Ordinal(0)] 
		[RED("compiledSmartObjects")] 
		public CArray<gameCompiledSmartObjectNode> CompiledSmartObjects
		{
			get
			{
				if (_compiledSmartObjects == null)
				{
					_compiledSmartObjects = (CArray<gameCompiledSmartObjectNode>) CR2WTypeManager.Create("array:gameCompiledSmartObjectNode", "compiledSmartObjects", cr2w, this);
				}
				return _compiledSmartObjects;
			}
			set
			{
				if (_compiledSmartObjects == value)
				{
					return;
				}
				_compiledSmartObjects = value;
				PropertySet(this);
			}
		}

		public gameCompiledNodes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
