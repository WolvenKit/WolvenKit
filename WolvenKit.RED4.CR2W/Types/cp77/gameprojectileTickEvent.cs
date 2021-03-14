using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileTickEvent : redEvent
	{
		private CFloat _deltaTime;
		private Vector4 _position;

		[Ordinal(0)] 
		[RED("deltaTime")] 
		public CFloat DeltaTime
		{
			get
			{
				if (_deltaTime == null)
				{
					_deltaTime = (CFloat) CR2WTypeManager.Create("Float", "deltaTime", cr2w, this);
				}
				return _deltaTime;
			}
			set
			{
				if (_deltaTime == value)
				{
					return;
				}
				_deltaTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("position")] 
		public Vector4 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector4) CR2WTypeManager.Create("Vector4", "position", cr2w, this);
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

		public gameprojectileTickEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
