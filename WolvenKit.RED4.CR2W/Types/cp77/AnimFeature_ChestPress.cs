using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_ChestPress : animAnimFeature
	{
		private CBool _lifting;
		private CBool _kill;

		[Ordinal(0)] 
		[RED("lifting")] 
		public CBool Lifting
		{
			get
			{
				if (_lifting == null)
				{
					_lifting = (CBool) CR2WTypeManager.Create("Bool", "lifting", cr2w, this);
				}
				return _lifting;
			}
			set
			{
				if (_lifting == value)
				{
					return;
				}
				_lifting = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("kill")] 
		public CBool Kill
		{
			get
			{
				if (_kill == null)
				{
					_kill = (CBool) CR2WTypeManager.Create("Bool", "kill", cr2w, this);
				}
				return _kill;
			}
			set
			{
				if (_kill == value)
				{
					return;
				}
				_kill = value;
				PropertySet(this);
			}
		}

		public AnimFeature_ChestPress(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
