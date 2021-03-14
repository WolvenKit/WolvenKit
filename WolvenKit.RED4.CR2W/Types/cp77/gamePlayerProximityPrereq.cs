using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePlayerProximityPrereq : gameIPrereq
	{
		private CFloat _squaredRange;

		[Ordinal(0)] 
		[RED("squaredRange")] 
		public CFloat SquaredRange
		{
			get
			{
				if (_squaredRange == null)
				{
					_squaredRange = (CFloat) CR2WTypeManager.Create("Float", "squaredRange", cr2w, this);
				}
				return _squaredRange;
			}
			set
			{
				if (_squaredRange == value)
				{
					return;
				}
				_squaredRange = value;
				PropertySet(this);
			}
		}

		public gamePlayerProximityPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
