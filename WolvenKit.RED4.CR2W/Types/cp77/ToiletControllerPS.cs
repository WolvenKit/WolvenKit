using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToiletControllerPS : ScriptableDeviceComponentPS
	{
		private CFloat _flushDuration;
		private CName _flushSFX;
		private CName _flushVFXname;
		private CBool _isFlushing;

		[Ordinal(103)] 
		[RED("flushDuration")] 
		public CFloat FlushDuration
		{
			get
			{
				if (_flushDuration == null)
				{
					_flushDuration = (CFloat) CR2WTypeManager.Create("Float", "flushDuration", cr2w, this);
				}
				return _flushDuration;
			}
			set
			{
				if (_flushDuration == value)
				{
					return;
				}
				_flushDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("flushSFX")] 
		public CName FlushSFX
		{
			get
			{
				if (_flushSFX == null)
				{
					_flushSFX = (CName) CR2WTypeManager.Create("CName", "flushSFX", cr2w, this);
				}
				return _flushSFX;
			}
			set
			{
				if (_flushSFX == value)
				{
					return;
				}
				_flushSFX = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("flushVFXname")] 
		public CName FlushVFXname
		{
			get
			{
				if (_flushVFXname == null)
				{
					_flushVFXname = (CName) CR2WTypeManager.Create("CName", "flushVFXname", cr2w, this);
				}
				return _flushVFXname;
			}
			set
			{
				if (_flushVFXname == value)
				{
					return;
				}
				_flushVFXname = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("isFlushing")] 
		public CBool IsFlushing
		{
			get
			{
				if (_isFlushing == null)
				{
					_isFlushing = (CBool) CR2WTypeManager.Create("Bool", "isFlushing", cr2w, this);
				}
				return _isFlushing;
			}
			set
			{
				if (_isFlushing == value)
				{
					return;
				}
				_isFlushing = value;
				PropertySet(this);
			}
		}

		public ToiletControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
