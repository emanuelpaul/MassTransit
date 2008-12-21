// Copyright 2007-2008 The Apache Software Foundation.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.Services.Subscriptions.Messages
{
    using System;
    using MassTransit.Subscriptions;

    [Serializable]
    public class RemoveSubscription :
        SubscriptionChange
    {
        protected RemoveSubscription()
        {
        }

        public RemoveSubscription(string messageName, Uri address)
            : base(messageName, address)
        {
        }

        public RemoveSubscription(SubscriptionInformation subscription)
            : base(subscription)
        {
        }

        public bool Equals(RemoveSubscription obj)
        {
            return base.Equals(obj);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return Equals(obj as RemoveSubscription);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}