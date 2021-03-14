using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamWaterPatchData : meshMeshParameter
	{
		private CBool _animLoop;
		private CFloat _animLength;
		private CStatic<CStatic<CFloat>> _nodes;

		[Ordinal(0)] 
		[RED("animLoop")] 
		public CBool AnimLoop
		{
			get
			{
				if (_animLoop == null)
				{
					_animLoop = (CBool) CR2WTypeManager.Create("Bool", "animLoop", cr2w, this);
				}
				return _animLoop;
			}
			set
			{
				if (_animLoop == value)
				{
					return;
				}
				_animLoop = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("animLength")] 
		public CFloat AnimLength
		{
			get
			{
				if (_animLength == null)
				{
					_animLength = (CFloat) CR2WTypeManager.Create("Float", "animLength", cr2w, this);
				}
				return _animLength;
			}
			set
			{
				if (_animLength == value)
				{
					return;
				}
				_animLength = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("nodes", 4096)] 
		public CStatic<CStatic<CFloat>> Nodes
		{
			get
			{
				if (_nodes == null)
				{
					_nodes = (CStatic<CStatic<CFloat>>) CR2WTypeManager.Create("static:4096,static:16,Float", "nodes", cr2w, this);
				}
				return _nodes;
			}
			set
			{
				if (_nodes == value)
				{
					return;
				}
				_nodes = value;
				PropertySet(this);
			}
		}

		public meshMeshParamWaterPatchData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
