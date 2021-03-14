using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameweaponAnimFeature_LoopableAction : animAnimFeature
	{
		private CFloat _loopDuration;
		private CUInt8 _numLoops;
		private CBool _isActive;

		[Ordinal(0)] 
		[RED("loopDuration")] 
		public CFloat LoopDuration
		{
			get
			{
				if (_loopDuration == null)
				{
					_loopDuration = (CFloat) CR2WTypeManager.Create("Float", "loopDuration", cr2w, this);
				}
				return _loopDuration;
			}
			set
			{
				if (_loopDuration == value)
				{
					return;
				}
				_loopDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("numLoops")] 
		public CUInt8 NumLoops
		{
			get
			{
				if (_numLoops == null)
				{
					_numLoops = (CUInt8) CR2WTypeManager.Create("Uint8", "numLoops", cr2w, this);
				}
				return _numLoops;
			}
			set
			{
				if (_numLoops == value)
				{
					return;
				}
				_numLoops = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		public gameweaponAnimFeature_LoopableAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
