using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExitFromVehicle : AIVehicleTaskAbstract
	{
		private CBool _useFastExit;
		private CBool _tryBlendToWalk;

		[Ordinal(0)] 
		[RED("useFastExit")] 
		public CBool UseFastExit
		{
			get
			{
				if (_useFastExit == null)
				{
					_useFastExit = (CBool) CR2WTypeManager.Create("Bool", "useFastExit", cr2w, this);
				}
				return _useFastExit;
			}
			set
			{
				if (_useFastExit == value)
				{
					return;
				}
				_useFastExit = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("tryBlendToWalk")] 
		public CBool TryBlendToWalk
		{
			get
			{
				if (_tryBlendToWalk == null)
				{
					_tryBlendToWalk = (CBool) CR2WTypeManager.Create("Bool", "tryBlendToWalk", cr2w, this);
				}
				return _tryBlendToWalk;
			}
			set
			{
				if (_tryBlendToWalk == value)
				{
					return;
				}
				_tryBlendToWalk = value;
				PropertySet(this);
			}
		}

		public ExitFromVehicle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
