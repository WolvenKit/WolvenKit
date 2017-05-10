using System.Collections.Generic;
using System.IO;

namespace SoundBankParser.Sections
{
    internal class SoundStructure_effect
    {
        public byte effectindex; //00 - 03
        public uint id;
        public byte[] zeroes;

        public SoundStructure_effect(BinaryReader instream)
        {
            effectindex = instream.ReadByte();
            id = instream.ReadUInt32();
            zeroes = instream.ReadBytes(2);
        }

        public void StreamWrite(BinaryWriter outstream)
        {
            outstream.Write(effectindex);
            outstream.Write(id);
            outstream.Write(zeroes);
        }
    }

    internal class SoundStructure_stategroup
    {
        public byte changeAt;

        public List<SoundStructure_stategroup_different> differingStates =
            new List<SoundStructure_stategroup_different>();

        public uint id;
        public ushort number_of_differingStates;

        public SoundStructure_stategroup(BinaryReader instream)
        {
            id = instream.ReadUInt32();
            changeAt = instream.ReadByte();
            number_of_differingStates = instream.ReadUInt16();
            for (var y = 0; y < number_of_differingStates; y++)
                differingStates.Add(new SoundStructure_stategroup_different(instream));
        }

        public void StreamWrite(BinaryWriter outstream)
        {
            outstream.Write(id);
            outstream.Write(changeAt);
            outstream.Write(number_of_differingStates);
            foreach (var diffstate in differingStates)
                diffstate.StreamWrite(outstream);
        }
    }

    internal class SoundStructure_stategroup_different
    {
        public uint id;
        public uint settingsID;

        public SoundStructure_stategroup_different(BinaryReader instream)
        {
            id = instream.ReadUInt32();
            settingsID = instream.ReadUInt32();
        }

        public void StreamWrite(BinaryWriter outstream)
        {
            outstream.Write(id);
            outstream.Write(settingsID);
        }
    }

    internal class SoundStructure_rtpc
    {
        public uint id;
        public byte num_of_points;
        public List<SoundStructure_rtpc_point> points = new List<SoundStructure_rtpc_point>();
        public byte unknown1;
        public byte unknown2;
        public uint unknownID;
        public uint yaxisType;

        public SoundStructure_rtpc(BinaryReader instream)
        {
            id = instream.ReadUInt32();
            yaxisType = instream.ReadUInt32();
            unknownID = instream.ReadUInt32();
            unknown1 = instream.ReadByte();
            num_of_points = instream.ReadByte();
            unknown2 = instream.ReadByte();
            for (var y = 0; y < num_of_points; y++)
                points.Add(new SoundStructure_rtpc_point(instream));
        }

        public void StreamWrite(BinaryWriter outstream)
        {
            outstream.Write(id);
            outstream.Write(yaxisType);
            outstream.Write(unknownID);
            outstream.Write(unknown1);
            outstream.Write(num_of_points);
            outstream.Write(unknown2);
            foreach (var rtpc_point in points)
                rtpc_point.StreamWrite(outstream);
        }
    }

    internal class SoundStructure_rtpc_point
    {
        public uint curveShape;
        public float x;
        public float y;

        public SoundStructure_rtpc_point(BinaryReader instream)
        {
            x = instream.ReadSingle();
            y = instream.ReadSingle();
            curveShape = instream.ReadUInt32();
        }

        public void StreamWrite(BinaryWriter outstream)
        {
            outstream.Write(x);
            outstream.Write(y);
            outstream.Write(curveShape);
        }
    }

    internal class SoundStructure
    {
        public byte additionalParameters_count;
        public List<byte> additionalParametersType = new List<byte>();
        public List<object> additionalParametersValue = new List<object>();
        //if udas_exists
        public uint auxiliaryBus0ID;
        public uint auxiliaryBus1ID;
        public uint auxiliaryBus2ID;
        public uint auxiliaryBus3ID;
        //if effects_count > 0
        public byte[] effect_bypassedeffects;
        public List<SoundStructure_effect> effects = new List<SoundStructure_effect>();
        public byte effects_count;
        //end if
        public byte instanceLimitType; //00 = per game object, 01 = globally
        public bool isPositioningIncluded;
        public uint limitInstancesTo;
        public byte limitReached; //00 = kill voice, 01 = user virtual voice settings
        private long offset;
        public bool offsetpriority;
        //end if
        public uint outputbusID;
        ////end if
        //end if
        //end if
        public bool overrideparentsettings_gdas; //Game-Defined Auxiliary Sends
        public bool overrideparentsettings_playbacklimit;
        public bool overrideparentsettings_priority;
        public bool overrideparentsettings_virtualvoice;
        public bool overrrideparentsettings_udas; //User-Defined Auxiliary Sends
        public uint parentobjectID;
        public bool parentOverride;
        public uint pos_attenuationObjectID;
        //if type == 00
        public bool pos_enablePanner;
        public bool pos_followListenerOrientation;
        public bool pos_isLooped; //ignore if playType != 02 || 03
        public bool pos_isSpatializationEnabled;
        ////if sourceType == 02
        public uint pos_playType;
        //else if type == 01
        public uint pos_sourceType; //02 = User-defined. 03 = Game-defined
        public uint pos_transitionTime; //in ms, ignore if playType != 02 || 03
        //if isPositioningIncluded
        public byte pos_type; //00 = 2D, 01 = 3D
        ////else if sourceType == 03
        public bool pos_updateAtEachFrame;
        //if unknown2
        public byte priorityEqual; //00 = discard oldest instance, 01 = discard newest instance
        public ushort rtpc_count; //Real-time parameter controls
        public List<SoundStructure_rtpc> rtpcs = new List<SoundStructure_rtpc>();
        public uint stategroup_count;
        public List<SoundStructure_stategroup> stategroups = new List<SoundStructure_stategroup>();
        public bool udas_exists;
        public byte unknown1;
        //end if
        public bool unknown2;
        public bool usegdas;
        public byte virtualvoicebehavior; //00 = continue to play, 01 = kill voice, 02 = send to virtual voice

        public SoundStructure(BinaryReader instream)
        {
            offset = instream.BaseStream.Position;
            parentOverride = instream.ReadBoolean();
            effects_count = instream.ReadByte();

            if (effects_count > 0)
            {
                effect_bypassedeffects = instream.ReadBytes(8);

                for (var x = 0; x < effects_count; x++)
                    effects.Add(new SoundStructure_effect(instream));
            }
            outputbusID = instream.ReadUInt32();
            parentobjectID = instream.ReadUInt32();
            overrideparentsettings_priority = instream.ReadBoolean();
            offsetpriority = instream.ReadBoolean();
            additionalParameters_count = instream.ReadByte();
            for (var x = 0; x < additionalParameters_count; x++)
                additionalParametersType.Add(instream.ReadByte());

            for (var x = 0; x < additionalParameters_count; x++)
                additionalParametersValue.Add((additionalParametersType[x] == 0x07
                    ? instream.ReadUInt32()
                    : instream.ReadSingle()));

            //FOR RESEARCH, REMOVE
            for (var x = 0; x < additionalParameters_count; x++)
            {
                if (StaticStorage.parameters.ContainsKey(additionalParametersType[x]))
                    StaticStorage.parameters[additionalParametersType[x]].Add(additionalParametersValue[x]);
                else
                {
                    var newparamsvals = new HashSet<object>();
                    newparamsvals.Add(additionalParametersValue[x]);
                    StaticStorage.parameters.Add(additionalParametersType[x], newparamsvals);
                }
            }

            /*
            if (!this.additionalParametersType.Contains((byte)00))
            {
                this.additionalParametersType.Add((byte)(00)); //REMOVE
                this.additionalParametersValue.Add(150.0f); //REMOVE
                this.additionalParameters_count++; //REMOVE
            }
            else
            {
                this.additionalParametersValue[this.additionalParametersType.FindIndex(e => e == (byte)00)] = 150.0f;
            }*/

            unknown1 = instream.ReadByte();
            isPositioningIncluded = instream.ReadBoolean();
            if (isPositioningIncluded)
            {
                pos_type = instream.ReadByte();
                if (pos_type == 00)
                {
                    pos_enablePanner = instream.ReadBoolean();
                }
                else if (pos_type == 01)
                {
                    pos_sourceType = instream.ReadUInt32();
                    pos_attenuationObjectID = instream.ReadUInt32();
                    pos_isSpatializationEnabled = instream.ReadBoolean();
                    if (pos_sourceType == 02)
                    {
                        pos_playType = instream.ReadUInt32();
                        pos_isLooped = instream.ReadBoolean();
                        pos_transitionTime = instream.ReadUInt32();
                        pos_followListenerOrientation = instream.ReadBoolean();
                    }
                    else if (pos_sourceType == 03)
                    {
                        pos_updateAtEachFrame = instream.ReadBoolean();
                    }
                }
            }
            overrideparentsettings_gdas = instream.ReadBoolean();
            usegdas = instream.ReadBoolean();
            overrrideparentsettings_udas = instream.ReadBoolean();
            udas_exists = instream.ReadBoolean();
            if (udas_exists)
            {
                auxiliaryBus0ID = instream.ReadUInt32();
                auxiliaryBus1ID = instream.ReadUInt32();
                auxiliaryBus2ID = instream.ReadUInt32();
                auxiliaryBus3ID = instream.ReadUInt32();
            }
            unknown2 = instream.ReadBoolean();
            if (unknown2)
            {
                priorityEqual = instream.ReadByte();
                limitReached = instream.ReadByte();
                limitInstancesTo = instream.ReadUInt32();
            }
            instanceLimitType = instream.ReadByte();
            virtualvoicebehavior = instream.ReadByte();
            overrideparentsettings_playbacklimit = instream.ReadBoolean();
            overrideparentsettings_virtualvoice = instream.ReadBoolean();
            stategroup_count = instream.ReadUInt32();
            for (var x = 0; x < stategroup_count; x++)
                stategroups.Add(new SoundStructure_stategroup(instream));
            rtpc_count = instream.ReadUInt16();
            for (var x = 0; x < rtpc_count; x++)
                rtpcs.Add(new SoundStructure_rtpc(instream));
        }

        public void StreamWrite(BinaryWriter outstream)
        {
            outstream.Write(parentOverride);
            outstream.Write(effects_count);
            if (effects_count > 0)
            {
                outstream.Write(effect_bypassedeffects);
                foreach (var effect in effects)
                    effect.StreamWrite(outstream);
            }
            outstream.Write(outputbusID);
            outstream.Write(parentobjectID);
            outstream.Write(overrideparentsettings_priority);
            outstream.Write(offsetpriority);
            outstream.Write(additionalParameters_count);
            foreach (var paramType in additionalParametersType)
                outstream.Write(paramType);
            foreach (var paramVal in additionalParametersValue)
            {
                if (paramVal is uint)
                    outstream.Write((uint) paramVal);
                else
                    outstream.Write((float) paramVal);
            }
            outstream.Write(unknown1);
            outstream.Write(isPositioningIncluded);
            if (isPositioningIncluded)
            {
                outstream.Write(pos_type);
                if (pos_type == 00)
                {
                    outstream.Write(pos_enablePanner);
                }
                else if (pos_type == 01)
                {
                    outstream.Write(pos_sourceType);
                    outstream.Write(pos_attenuationObjectID);
                    outstream.Write(pos_isSpatializationEnabled);
                    if (pos_sourceType == 02)
                    {
                        outstream.Write(pos_playType);
                        outstream.Write(pos_isLooped);
                        outstream.Write(pos_transitionTime);
                        outstream.Write(pos_followListenerOrientation);
                    }
                    else if (pos_sourceType == 03)
                    {
                        outstream.Write(pos_updateAtEachFrame);
                    }
                }
            }

            outstream.Write(overrideparentsettings_gdas);
            outstream.Write(usegdas);
            outstream.Write(overrrideparentsettings_udas);
            outstream.Write(udas_exists);
            if (udas_exists)
            {
                outstream.Write(auxiliaryBus0ID);
                outstream.Write(auxiliaryBus1ID);
                outstream.Write(auxiliaryBus2ID);
                outstream.Write(auxiliaryBus3ID);
            }
            outstream.Write(unknown2);
            if (unknown2)
            {
                outstream.Write(priorityEqual);
                outstream.Write(limitReached);
                outstream.Write(limitInstancesTo);
            }
            outstream.Write(instanceLimitType);
            outstream.Write(virtualvoicebehavior);
            outstream.Write(overrideparentsettings_playbacklimit);
            outstream.Write(overrideparentsettings_virtualvoice);
            outstream.Write(stategroup_count);
            foreach (var stateg in stategroups)
                stateg.StreamWrite(outstream);
            outstream.Write(rtpc_count);
            foreach (var rtpc in rtpcs)
                rtpc.StreamWrite(outstream);
        }
    }
}