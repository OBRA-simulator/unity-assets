//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Obr
{
    [Serializable]
    public class BiasMsg : Message
    {
        public const string k_RosMessageName = "obr_msgs/Bias";
        public override string RosMessageName => k_RosMessageName;

        public float angle;
        public float strength;
        public float speed;

        public BiasMsg()
        {
            this.angle = 0.0f;
            this.strength = 0.0f;
            this.speed = 0.0f;
        }

        public BiasMsg(float angle, float strength, float speed)
        {
            this.angle = angle;
            this.strength = strength;
            this.speed = speed;
        }

        public static BiasMsg Deserialize(MessageDeserializer deserializer) => new BiasMsg(deserializer);

        private BiasMsg(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.angle);
            deserializer.Read(out this.strength);
            deserializer.Read(out this.speed);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.angle);
            serializer.Write(this.strength);
            serializer.Write(this.speed);
        }

        public override string ToString()
        {
            return "BiasMsg: " +
            "\nangle: " + angle.ToString() +
            "\nstrength: " + strength.ToString() +
            "\nspeed: " + speed.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}