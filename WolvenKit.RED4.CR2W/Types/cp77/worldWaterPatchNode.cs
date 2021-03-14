using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldWaterPatchNode : worldMeshNode
	{
		private worldWaterPatchNodeType _type;
		private CFloat _depth;

		[Ordinal(15)] 
		[RED("type")] 
		public worldWaterPatchNodeType Type
		{
			get
			{
				if (_type == null)
				{
					_type = (worldWaterPatchNodeType) CR2WTypeManager.Create("worldWaterPatchNodeType", "type", cr2w, this);
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

		[Ordinal(16)] 
		[RED("depth")] 
		public CFloat Depth
		{
			get
			{
				if (_depth == null)
				{
					_depth = (CFloat) CR2WTypeManager.Create("Float", "depth", cr2w, this);
				}
				return _depth;
			}
			set
			{
				if (_depth == value)
				{
					return;
				}
				_depth = value;
				PropertySet(this);
			}
		}

		public worldWaterPatchNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
