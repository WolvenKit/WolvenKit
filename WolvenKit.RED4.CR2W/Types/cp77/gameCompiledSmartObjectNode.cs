using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCompiledSmartObjectNode : CVariable
	{
		private CHandle<gameCompiledSmartObjectData> _compiledData;
		private WorldTransform _worldTransform;

		[Ordinal(0)] 
		[RED("compiledData")] 
		public CHandle<gameCompiledSmartObjectData> CompiledData
		{
			get
			{
				if (_compiledData == null)
				{
					_compiledData = (CHandle<gameCompiledSmartObjectData>) CR2WTypeManager.Create("handle:gameCompiledSmartObjectData", "compiledData", cr2w, this);
				}
				return _compiledData;
			}
			set
			{
				if (_compiledData == value)
				{
					return;
				}
				_compiledData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("worldTransform")] 
		public WorldTransform WorldTransform
		{
			get
			{
				if (_worldTransform == null)
				{
					_worldTransform = (WorldTransform) CR2WTypeManager.Create("WorldTransform", "worldTransform", cr2w, this);
				}
				return _worldTransform;
			}
			set
			{
				if (_worldTransform == value)
				{
					return;
				}
				_worldTransform = value;
				PropertySet(this);
			}
		}

		public gameCompiledSmartObjectNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
