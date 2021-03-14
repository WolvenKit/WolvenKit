using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimationsConstructor : IScriptable
	{
		private CFloat _duration;
		private CEnum<inkanimInterpolationType> _type;
		private CEnum<inkanimInterpolationMode> _mode;
		private CBool _isAdditive;

		[Ordinal(0)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<inkanimInterpolationType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<inkanimInterpolationType>) CR2WTypeManager.Create("inkanimInterpolationType", "type", cr2w, this);
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

		[Ordinal(2)] 
		[RED("mode")] 
		public CEnum<inkanimInterpolationMode> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<inkanimInterpolationMode>) CR2WTypeManager.Create("inkanimInterpolationMode", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isAdditive")] 
		public CBool IsAdditive
		{
			get
			{
				if (_isAdditive == null)
				{
					_isAdditive = (CBool) CR2WTypeManager.Create("Bool", "isAdditive", cr2w, this);
				}
				return _isAdditive;
			}
			set
			{
				if (_isAdditive == value)
				{
					return;
				}
				_isAdditive = value;
				PropertySet(this);
			}
		}

		public AnimationsConstructor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
