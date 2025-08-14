import React from "react"
import { createFileRoute } from '@tanstack/react-router'
import MailResenderrComponent from '../../mailresenderr-component'

export const Route = createFileRoute('/mailresenderr/')({
  component: RouteComponent,
})

function RouteComponent() {
  return (
    <div>
      <MailResenderrComponent name="World!" />
    </div>
  )
}
