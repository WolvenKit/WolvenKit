using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_BulletImpact : gameEffectExecutor
	{
		private CBool _isBackfaceImpact;
		private CBool _noAudio;
		private CBool _isMeleeAttack;

		[Ordinal(1)] 
		[RED("isBackfaceImpact")] 
		public CBool IsBackfaceImpact
		{
			get
			{
				if (_isBackfaceImpact == null)
				{
					_isBackfaceImpact = (CBool) CR2WTypeManager.Create("Bool", "isBackfaceImpact", cr2w, this);
				}
				return _isBackfaceImpact;
			}
			set
			{
				if (_isBackfaceImpact == value)
				{
					return;
				}
				_isBackfaceImpact = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("noAudio")] 
		public CBool NoAudio
		{
			get
			{
				if (_noAudio == null)
				{
					_noAudio = (CBool) CR2WTypeManager.Create("Bool", "noAudio", cr2w, this);
				}
				return _noAudio;
			}
			set
			{
				if (_noAudio == value)
				{
					return;
				}
				_noAudio = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isMeleeAttack")] 
		public CBool IsMeleeAttack
		{
			get
			{
				if (_isMeleeAttack == null)
				{
					_isMeleeAttack = (CBool) CR2WTypeManager.Create("Bool", "isMeleeAttack", cr2w, this);
				}
				return _isMeleeAttack;
			}
			set
			{
				if (_isMeleeAttack == value)
				{
					return;
				}
				_isMeleeAttack = value;
				PropertySet(this);
			}
		}

		public gameEffectExecutor_BulletImpact(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
