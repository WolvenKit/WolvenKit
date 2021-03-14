using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameNetrunnerPrototypeSpawnRequestEvent : redEvent
	{
		private CName _whatToSpawn;
		private Vector3 _whereToSpawn;
		private Vector3 _scale;
		private CUInt8 _colorIndex;

		[Ordinal(0)] 
		[RED("whatToSpawn")] 
		public CName WhatToSpawn
		{
			get
			{
				if (_whatToSpawn == null)
				{
					_whatToSpawn = (CName) CR2WTypeManager.Create("CName", "whatToSpawn", cr2w, this);
				}
				return _whatToSpawn;
			}
			set
			{
				if (_whatToSpawn == value)
				{
					return;
				}
				_whatToSpawn = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("whereToSpawn")] 
		public Vector3 WhereToSpawn
		{
			get
			{
				if (_whereToSpawn == null)
				{
					_whereToSpawn = (Vector3) CR2WTypeManager.Create("Vector3", "whereToSpawn", cr2w, this);
				}
				return _whereToSpawn;
			}
			set
			{
				if (_whereToSpawn == value)
				{
					return;
				}
				_whereToSpawn = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("scale")] 
		public Vector3 Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (Vector3) CR2WTypeManager.Create("Vector3", "scale", cr2w, this);
				}
				return _scale;
			}
			set
			{
				if (_scale == value)
				{
					return;
				}
				_scale = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("colorIndex")] 
		public CUInt8 ColorIndex
		{
			get
			{
				if (_colorIndex == null)
				{
					_colorIndex = (CUInt8) CR2WTypeManager.Create("Uint8", "colorIndex", cr2w, this);
				}
				return _colorIndex;
			}
			set
			{
				if (_colorIndex == value)
				{
					return;
				}
				_colorIndex = value;
				PropertySet(this);
			}
		}

		public gameNetrunnerPrototypeSpawnRequestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
