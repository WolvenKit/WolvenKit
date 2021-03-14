using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorGenerateSearchInfluenceTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _position;
		private CHandle<AIArgumentMapping> _path;
		private CHandle<AIArgumentMapping> _radius;

		[Ordinal(1)] 
		[RED("position")] 
		public CHandle<AIArgumentMapping> Position
		{
			get
			{
				if (_position == null)
				{
					_position = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("path")] 
		public CHandle<AIArgumentMapping> Path
		{
			get
			{
				if (_path == null)
				{
					_path = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "path", cr2w, this);
				}
				return _path;
			}
			set
			{
				if (_path == value)
				{
					return;
				}
				_path = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("radius")] 
		public CHandle<AIArgumentMapping> Radius
		{
			get
			{
				if (_radius == null)
				{
					_radius = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "radius", cr2w, this);
				}
				return _radius;
			}
			set
			{
				if (_radius == value)
				{
					return;
				}
				_radius = value;
				PropertySet(this);
			}
		}

		public AIbehaviorGenerateSearchInfluenceTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
