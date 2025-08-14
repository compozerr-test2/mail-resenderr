import React from "react";

interface Props {
   name: string;
}

const MailResenderrComponent = (props: Props) => {
   return (
      <div>
         Hello {props.name}
      </div>
   );
}

export default MailResenderrComponent;